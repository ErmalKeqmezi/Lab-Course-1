import * as React from "react";
import { useTheme, createTheme } from "@mui/material/styles";
import Box from "@mui/material/Box";
import Card from "@mui/material/Card";
import CardContent from "@mui/material/CardContent";
import CardMedia from "@mui/material/CardMedia";
import IconButton from "@mui/material/IconButton";
import Typography from "@mui/material/Typography";
import SkipPreviousIcon from "@mui/icons-material/SkipPrevious";
import PlayArrowIcon from "@mui/icons-material/PlayArrow";
import SkipNextIcon from "@mui/icons-material/SkipNext";
import TextField from "@mui/material/TextField";
import Button from "@mui/material/Button";

import { useState } from "react";

export default function MediaControlCard() {
  const [darkMode, setDarkMode] = useState(false);
  const palleteType = darkMode ? "dark" : "light";
  const theme = createTheme({
    palette: {
      mode: palleteType,
      primary: {
        main: "#CE1212",
      },
      secondary: {
        main: "#810000",
      },
      background: {
        default: palleteType === "light" ? "#EEEBDD" : "#1B1717",
      },
    },
  });

  return (
    <Card
      sx={{
        display: "flex",
        bgcolor: "#CE1212",
        mb: 8,
        alignContent: "center",
      }}
    >
      <Box
        sx={{
          display: "flex",
          flexDirection: "column",
          m: 5,
          width: "50%",
          flex: "1 1 0",
        }}
      >
        <CardContent sx={{ flex: "4 0 auto" }}>
          <Typography component="div" variant="h5">
            Subscribe to our Newsletter!
          </Typography>
          <Typography
            variant="subtitle1"
            color="text.secondary"
            component="div"
          >
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Error
            assumenda, maiores alias molestiae cupiditate sit ad nihil! Quaerat
            corporis labore fugit autem cum ad iusto repellat hic ab? Ex,
            veritatis.
          </Typography>
        </CardContent>
      </Box>
      <Box
        sx={{
          display: "flex",
          flexDirection: "row",
          mb: 5,
          mt: 5,
          width: "50%",
          flex: "1 1 0 0",
        }}
      >
        <TextField
          id="outlined-basic"
          label="Email"
          variant="outlined"
          sx={{
            width: "50%",
            bgcolor: "#EEEBDD",
            alignContent: "center",
            mb: 10,
            mt: 10,
          }}
        />
        <Button
          variant="contained"
          sx={{ height: "26%", mb: 10, mt: 10, bgcolor: "#810000" }}
        >
          Submit
        </Button>
      </Box>
    </Card>
  );
}
