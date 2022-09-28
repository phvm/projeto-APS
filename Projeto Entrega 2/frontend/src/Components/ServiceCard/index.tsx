import { Box } from "@mui/material";
import { ServiceCardProps } from "../../types/componentsTypes/ServiceCardProps";

export default function ServiceCard(props: ServiceCardProps) {
  const { imgSrc, title, description, linkTo } = props;
  return (
    <a
      href={linkTo}
      style={{
        maxWidth: "14em",
        width: "60%",
        height: '30%',
        borderRadius: "15px",
        backgroundColor: "#ffffff",
        border: "1px solid #E63462",
        textDecoration: "none",
        padding: "1%",
        display: "flex",
        flexDirection: "column",
        alignItems: "center",
      }}
    >
      <img style={{ width: "40%" }} src={imgSrc} alt="" />
      <Box sx={{textAlign: "left"}}>
        <h2 style={{ color: "#262626" }}>{title}</h2>
        <p style={{ color: "#262626" }}>{description}</p>
      </Box>
    </a>
  );
}
