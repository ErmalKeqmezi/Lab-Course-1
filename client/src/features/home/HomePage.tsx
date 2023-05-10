import { Box, Typography } from "@mui/material";
import Slider from "react-slick";
import "./home.css";
export default function HomePage() {
  const settings = {
    dots: true,
    infinite: true,
    speed: 500,
    slidesToShow: 1,
    slidesToScroll: 1,
  };

<<<<<<< HEAD
  return (
    <>
      <Slider {...settings}>
        <div>
          <img
            src="/images/hero1.jpg"
            alt="hero"
            style={{ display: "block", width: "100%", maxHeight: 500 }}
          />
        </div>
        <div>
          <img
            src="/images/hero2.jpg"
            alt="hero"
            style={{ display: "block", width: "100%", maxHeight: 500 }}
          />
        </div>
        <div>
          <img
            src="/images/hero3.jpg"
            alt="hero"
            style={{ display: "block", width: "100%", maxHeight: 500 }}
          />
        </div>
      </Slider>
=======
    return (
        <>
            <Slider {...settings}>
                <div>
                    <img src="/images/hero1.jpeg" alt="hero" style={{display: 'block', width: '100%', maxHeight: 500}}/>
                </div>
                <div>
                    <img src="/images/hero2.jpeg" alt="hero" style={{display: 'block', width: '100%', maxHeight: 500}}/>
                </div>
            </Slider>
>>>>>>> a14075cc1c8c524c37a7e5f75e1deb9072825859

      <Box display="flex" justifyContent="center" sx={{ p: 4 }}>
        <Typography variant="h1" fontFamily={"Zebrafont"} textAlign={"center"}>
          Welcome to <br /> Zebra69 <hr />
        </Typography>
      </Box>
    </>
  );
}
