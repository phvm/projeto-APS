import { Box } from "@mui/material";
import { NavBarProps } from "../../types/componentsTypes/NavBarProps";

export default function NavBar(props: NavBarProps) {
  const { title } = props;
  return (
    <>
      <Box
        sx={{
          height: "15%",
          padding: "1% 2%",
          backgroundColor: "#f2f0f0",
        }}
      >
        <h1 style={{ textAlign: "left", fontSize: "2.5em", color: "#05D5B2" }}>
          {title}
        </h1>
      </Box>
      <Box sx={{width: '100%', height: '0.4em', borderRadius: '0 0 15px 15px', backgroundColor: '#05D5B2'}}></Box>
    </>
  );
}
