import { Box, Typography, FormControl, OutlinedInput, Input, InputLabel, Button } from "@mui/material";
import { LoginFormProps } from '../../types/componentsTypes/LoginFormProps';

const LoginForm = (props: LoginFormProps) => {
    return(
        <Box sx={{boxSizing: 'border-box', width: '80%', height: '80%', backgroundColor: '#F2F0F0', borderRadius: '35px', padding: '3em', display: 'flex', flexDirection: 'column', justifyContent: 'space-evenly'}}>
            <Typography variant="h3" align='left' sx={{color: '#E63462', fontSize: '2.5rem'}}>
                Bem-vindo de volta!
            </Typography>
            <Typography variant="h5" align='left' sx={{color: '#262626', fontSize: '1.5rem'}}>
                Por favor, informe seu CPF e senha
            </Typography>
            <Box sx={{ width: '100%', display: 'flex', flexDirection: 'column', }}>
                <FormControl>
                    <InputLabel htmlFor="component-outlined">CPF</InputLabel>
                    <OutlinedInput required placeholder="Digite seu CPF..." />
                </FormControl>
                <FormControl>
                    <InputLabel>Senha</InputLabel>
                    <OutlinedInput required placeholder="Digite sua senha..." />
                </FormControl>
                <Button>Login</Button>
            </Box>
            <Box>
                <Typography variant="h5" align='center'>
                    Se ainda não é cadastrado <br/>
                    <p style={{color: '#E63462'}}>clique aqui!</p>
                </Typography>
            </Box>
        </Box>
    );
};

export default LoginForm;