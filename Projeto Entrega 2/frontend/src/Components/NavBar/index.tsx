import { Box } from "@mui/material";
import { NavBarProps } from "../../types/componentsTypes/NavBarProps";

export default function NavBar(props: NavBarProps) {
  const { title } = props;
  return (
    <Box sx={{ width: "100%", height: "15%", padding: "2% 5%" }}>
      <h1 style={{ textAlign: "left" }}>{title}</h1>
    </Box>
  );
}
