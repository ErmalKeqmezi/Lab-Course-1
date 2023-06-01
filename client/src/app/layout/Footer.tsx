import Box from "@mui/material/Box";
import * as React from "react";
import Container from "@mui/material/Container";
import Typography from "@mui/material/Typography";
import Grid from "@mui/material/Grid";
import Stack from "@mui/material/Stack";
import Select from "@mui/material/Select";
import { Link, NavLink } from "react-router-dom";
import MenuItem from "@mui/material/MenuItem";
import InstagramIcon from "@mui/icons-material/Instagram";
import FacebookIcon from "@mui/icons-material/Facebook";
import YouTubeIcon from "@mui/icons-material/YouTube";
import LinkedInIcon from "@mui/icons-material/LinkedIn";

const Footer = () => {
  return (
    <Box sx={{ bgcolor: "#272727", color: "grey.700" }}>
      <Container maxWidth="md" sx={{ py: 6 }}>
        <Stack spacing={4}>
          <Typography>Questions? Call 007-803-321-2130</Typography>

          <Box>
            <Grid container spacing={1}>
              <Grid item xs={6} md={3}>
                <InstagramIcon />
                <FacebookIcon />
                <YouTubeIcon />
                <LinkedInIcon />
              </Grid>
              <Grid item xs={6} md={3}>
                <Stack spacing={2}>
                  <Typography>Help Center</Typography>
                  <Typography>Jobs</Typography>
                  <Typography>Cookie Preferences</Typography>
                  <Typography>Legal Notices</Typography>
                </Stack>
              </Grid>
              <Grid item xs={6} md={3}>
                <Stack spacing={2}>
                  <Typography>Account</Typography>
                  <Typography>Ways to Watch</Typography>
                  <Typography>Corporate Information</Typography>
                  <Typography></Typography>
                </Stack>
              </Grid>
              <Grid item xs={6} md={3}>
                <Stack spacing={2}>
                  <Typography>Products</Typography>
                  <Typography>Terms of Use</Typography>
                  <Typography>Contact Us</Typography>
                </Stack>
              </Grid>
            </Grid>
          </Box>
        </Stack>
      </Container>
    </Box>
  );
};

export default Footer;
