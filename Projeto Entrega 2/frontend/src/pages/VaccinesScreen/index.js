import {
  Box,
  FormControl,
  InputLabel,
  OutlinedInput,
  Button,
} from "@mui/material";
import NavBar from "../../Components/NavBar";
import { useState } from "react";

const VaccinesScreen = () => {
  const [vaccine, setVaccine] = useState("");

  function handleChange(event) {
    setVaccine(event.target.value);
  }

  return (
    <Box sx={{ height: "100vh", width: "100vw", backgroundColor: "#f2f0f0" }}>
      <NavBar title="Vacinas" />
      <Box
        sx={{
          width: "90%",
          height: "50%",
          padding: "5%",
          display: "flex",
          justifyContent: "space-evenly",
          alignItems: "center",
        }}
      >
        <Box sx={{display: 'flex', justifyContent: 'space-evenly', alignItems: 'center'}}>
          <FormControl sx={{ width: "50%" }}>
            <InputLabel>Tipo de Vacina</InputLabel>
            <OutlinedInput
              onChange={handleChange}
              required
              placeholder="Digite o tipo da vacina..."
            />
          </FormControl>
          <Button
            type="submit"
            variant="contained"
            sx={{
              backgroundColor: "#05D5B2",
              fontSize: "1.2rem",
              fontWeight: "520",
              width: "25%",
            }}
          >
            Adicionar
          </Button>
          <Button
            type="submit"
            variant="contained"
            sx={{
              backgroundColor: "#E63462",
              fontSize: "1.2rem",
              fontWeight: "520",
              width: "25%",
            }}
          >
            Remover
          </Button>
        </Box>
      </Box>
    </Box>
  );
};

export default VaccinesScreen;
