import { Box } from "@mui/material";
import NavBar from "../../Components/NavBar";
import ServiceCard from "../../Components/ServiceCard";

export default function Home() {
  return (
    <Box sx={{ height: "100%", width: "100vw" }}>
      <NavBar title="vaCInnação" />
      <Box sx={{ backgroundColor: "#f2f0f0", padding: '5%' }}>
        <Box sx={{}}>
          <ServiceCard title='Vacinas' description="" />
        </Box>
      </Box>
    </Box>
  );
}
