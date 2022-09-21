import { Box } from "@mui/material";
import { ServiceCardProps } from "../../types/componentsTypes/ServiceCardProps";

export default function ServiceCard(props: ServiceCardProps) {
  const { imgSrc, title, description, linkTo } = props;
  return (
    <Box
      sx={{
        boxSizing: "border-box",
        width: "14em",
        height: "14em",
        display: "flex",
        flexDirection: "column",
        border: '1px solid #E63462',
        backgroundColor: '#ffffff',
        borderRadius: '15px',
        padding: '0 2%'
      }}
    >
      <a href={linkTo} style={{textDecoration: 'none'}}>
        <img src={imgSrc} alt="" />
        <Box sx={{width: '100%', backgroundColor: ''}}></Box>
        <h2 style={{color: '#262626'}}>{title}</h2>
        <p style={{color: '#262626'}}>{description}</p>
      </a>
    </Box>
  );
}
