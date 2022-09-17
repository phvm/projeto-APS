import { Box, Typography, FormControl, OutlinedInput, InputLabel, Button } from "@mui/material";
import { LoginFormProps } from '../../types/componentsTypes/LoginFormProps';
import { Links } from "../../types/enums";

const LoginForm = (props: LoginFormProps) => {
    return(
        <Box sx={{boxSizing: 'border-box', width: '80%', height: '80%', backgroundColor: '#F2F0F0', borderRadius: '35px', padding: '3em', display: 'flex', flexDirection: 'column', justifyContent: 'space-evenly'}}>
            <Box sx={{display: 'flex', flexDirection: 'column', height: '15%', justifyContent: 'space-around'}}>
                <Typography variant="h3" align='left' sx={{color: '#E63462', fontSize: '2.5rem'}}>
                    Bem-vindo de volta!
                </Typography>
                <Typography variant="h5" align='left' sx={{color: '#262626', fontSize: '1.5rem'}}>
                    Por favor, informe seu CPF e senha.
                </Typography>
            </Box>
            <Box sx={{ width: '100%', height: '40%', display: 'flex', flexDirection: 'column', justifyContent: 'space-around', alignItems: 'center'}}>
                <FormControl sx={{width: '100%'}}>
                    <InputLabel htmlFor="component-outlined">CPF</InputLabel>
                    <OutlinedInput required placeholder="Digite seu CPF..." />
                </FormControl>
                <FormControl sx={{width: '100%'}}>
                    <InputLabel>Senha</InputLabel>
                    <OutlinedInput required placeholder="Digite sua senha..." />
                </FormControl>
                <Button variant="contained" sx={{backgroundColor: '#E63462', fontSize: '1.2rem', fontWeight: '520', width: '20%'}}>Login</Button>
            </Box>
            <Box>
                <Typography variant="h5" align='center'>
                    Se ainda não é cadastrado <br/>
                    <a href={Links.Cadastro} style={{color: '#E63462'}}>clique aqui!</a>
                </Typography>
            </Box>
        </Box>
    );
};

export default LoginForm;