import { Box } from "@mui/material";
import NavBar from "../../Components/NavBar";
import ServiceCard from "../../Components/ServiceCard";
import { Links } from "../../types/enums";
import vaccineIcon from '../../assets/vaccineIcon.svg';

export default function Home() {
  return (
    <Box sx={{ height: "100vh", width: "100vw", backgroundColor: "#f2f0f0" }}>
      <NavBar title="vaCInnação" />
      <Box sx={{ padding: "5%", display: 'flex', justifyContent: 'center', alignItems: 'center' }}>
          <ServiceCard
            imgSrc={vaccineIcon}
            linkTo={Links.Vacinas}
            title="Vacinas"
            description="Serviço onde você pode adicionar ou remover vacinas."
          />
      </Box>
    </Box>
  );
}
