import {
  Box,
  Button,
  Typography,
  FormControl,
  InputLabel,
  OutlinedInput,
} from "@mui/material";
import { useState } from 'react'
import { Links } from "../../types/enums";
import { useNavigate } from "react-router-dom";
import axios from 'axios';

const RegisterForm = () => {
  const [formValue, setFormValue] = useState({
    nome: '',
    cpf: '',
    email: '',
    senha: ''
  });

  const navigate = useNavigate();
  
  async function registrarCidadao(nome, cpf, email, senha){
    const response = await axios.get(`localhost:3000/conta/registrarCidadao?cpf=${cpf}&${senha}&nome=${nome}&email=${email}`);

    const { status } = response;
   
    if (status === '200'){
      navigate(Links.Home);
    }
  }

  const handleChange = (prop) => (event) => {
    setFormValue({...formValue, [prop]: event.target.value });
  }

  const handleSubmit = () => {

  }
  return (
    <Box
      sx={{
        boxSizing: "border-box",
        width: "80%",
        height: "80%",
        backgroundColor: "#F2F0F0",
        borderRadius: "35px",
        padding: "1% 7%",
        display: "flex",
        flexDirection: "column",
        justifyContent: "space-evenly",
      }}
    >
      <Box
        sx={{
          display: "flex",
          flexDirection: "column",
          height: "15%",
          justifyContent: "space-around",
        }}
      >
        <Typography
          variant="h3"
          align="left"
          sx={{ color: "#E63462", fontSize: "2.5rem" }}
        >
          Seja bem-vindo!
        </Typography>
      </Box>
      <Box
        sx={{
          width: "100%",
          height: "40%",
          display: "flex",
          flexDirection: "column",
          justifyContent: "space-around",
          alignItems: "center",
        }}
      >
        <FormControl onChange={handleChange('nome')} sx={{ width: "100%" }}>
          <InputLabel htmlFor="component-outlined">Nome</InputLabel>
          <OutlinedInput required placeholder="Digite seu nome completo..." />
        </FormControl>
        <FormControl onChange={handleChange('cpf')} sx={{ width: "100%" }}>
          <InputLabel>CPF</InputLabel>
          <OutlinedInput required placeholder="Digite seu CPF..." />
        </FormControl>
        <FormControl onChange={handleChange('email')} sx={{ width: "100%" }}>
          <InputLabel>E-mail</InputLabel>
          <OutlinedInput required placeholder="Digite seu email..." />
        </FormControl>
        <FormControl onChange={handleChange('senha')} sx={{ width: "100%" }}>
          <InputLabel>Senha</InputLabel>
          <OutlinedInput type='password' required placeholder="Digite sua senha..." />
        </FormControl>
        <Button
          onClick={handleSubmit}
          variant="contained"
          sx={{
            backgroundColor: "#E63462",
            fontSize: "1.2rem",
            fontWeight: "520",
            width: "40%",
          }}
        >
          Registrar
        </Button>
      </Box>
      <Box>
        <Typography variant="h5" align="center">
          Se você já é cadastrado <br />
          <a href={Links.Login} style={{ color: "#E63462" }}>
            clique aqui!
          </a>
        </Typography>
      </Box>
    </Box>
  );
};

export default RegisterForm;
