import { LoadingButton } from "@mui/lab";
import * as React from "react";
import {
  Button,
  Card,
  CardActions,
  CardContent,
  CardHeader,
  CardMedia,
  Typography,
  Rating,
  Box,
  IconButton,
  Stack,
} from "@mui/material";
import { Link } from "react-router-dom";
import { Product } from "../../app/models/product";
import { useAppDispatch, useAppSelector } from "../../app/store/configureStore";
import { currencyFormat } from "../../app/util/util";
import { addBasketItemAsync } from "../basket/basketSlice";
import VisibilityIcon from "@mui/icons-material/Visibility";
import AddShoppingCartIcon from "@mui/icons-material/AddShoppingCart";

interface Props {
  product: Product;
}

export default function ProductCard({ product }: Props) {
  const { status } = useAppSelector((state) => state.basket);
  const dispatch = useAppDispatch();
  const [value, setValue] = React.useState<number | null>(0);

  return (
    <Card elevation={8}>
      <CardHeader
        title={product.name}
        titleTypographyProps={{
          sx: { fontWeight: "bold", fontSize: "17px" },
        }}
      />
      <CardMedia
        sx={{
          height: 140,
          backgroundSize: "contain",
          bgcolor: "#ededed",
          borderBottom: 0.5,
          borderTop: 0.5,
        }}
        image={product.pictureUrl}
        title={product.name}
      />
      <CardContent>
        <Typography
          gutterBottom
          color="inherit"
          variant="h5"
          // sx={{ fontWeight: 6 }}
        >
          <b>{currencyFormat(product.price)}</b>
        </Typography>
        <Rating
          name="simple-controlled"
          value={value}
          onChange={(event, newValue) => {
            setValue(newValue);
          }}
        />
      </CardContent>
      <CardActions>
        <LoadingButton
          sx={{
            border: 1,
            p: 1,
            ml: 1,
            ":hover": {
              bgcolor: "#6d6d6d",
              color: "white",
            },
          }}
          loading={status === "pendingAddItem" + product.id}
          onClick={() =>
            dispatch(addBasketItemAsync({ productId: product.id }))
          }
          size="small"
        >
          <AddShoppingCartIcon />
        </LoadingButton>
        <Button
          component={Link}
          to={`/catalog/${product.id}`}
          size="small"
          sx={{
            border: 1,
            p: 1,
            ml: 1,
            ":hover": {
              bgcolor: "#6d6d6d",
              color: "white",
            },
          }}
        >
          <VisibilityIcon />
        </Button>
      </CardActions>
    </Card>
  );
}
