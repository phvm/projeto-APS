import {
  Box,
  FormControl,
  InputLabel,
  OutlinedInput,
  Button,
} from "@mui/material";
import NavBar from "../../Components/NavBar";
import { useState } from "react";
import axios from 'axios';
import { Links } from "../../types/enums";

const VaccinesScreen = () => {
  const [vaccine, setVaccine] = useState({
    tipoVacina: '',
    descricao: ''
  });

  const handleChange = (prop) => (event) => {
    setVaccine({...vaccine, [prop]:event.target.value});
  };

  async function cadastrarVacina(tipoVacina, descricao){
    await axios.post(`localhost:3001/vacina/cadastrar?adminId=""&nome=${tipoVacina}&descicao=${descricao}`);
  };

  async function arquivarVacina(){
    await axios.post(`localhost:3001/vacina/cadastrar?adminId=""&vacinaId=""`);
  };

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
          <FormControl sx={{ width: "50%" }}>
            <InputLabel>Descrição da vacina</InputLabel>
            <OutlinedInput
              onChange={handleChange}
              required
              placeholder="Digite a descrição da vacina..."
            />
          </FormControl>
          <Button
            type="submit"
            variant="contained"
            onClick={cadastrarVacina}
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
            onClick={arquivarVacina}
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
