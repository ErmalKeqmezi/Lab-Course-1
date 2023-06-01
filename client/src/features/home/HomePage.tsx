import { Box, Typography, createTheme } from "@mui/material";
import Slider from "react-slick";
import "./home.css";
import Banner from "./Banner";
import { useState } from "react";
import ProductCard from "../catalog/ProductCard";
export default function HomePage() {
  const settings = {
    dots: true,
    infinite: true,
    arrows: false,
    speed: 500,
    slidesToShow: 1,
    slidesToScroll: 1,
  };

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

      <Box display="flex" justifyContent="center" sx={{ p: 4 }}>
        <Typography variant="h1" fontFamily={"Zebrafont"} textAlign={"center"}>
          Welcome to <br /> Zebra69
        </Typography>
      </Box>

      <Box>
        <Banner></Banner>
      </Box>
    </>
  );
}
