import { Box, Typography, TextField, FormControl, OutlinedInput, Input, InputLabel } from "@mui/material";
import { LoginFormProps } from '../../types/componentsTypes/LoginFormProps'

const LoginForm = (props: LoginFormProps) => {
    return(
        <Box sx={{width: props.width, height: props.height, padding: '8%'}}>
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
            </Box>
            <Box>
                <Typography variant="h5" align='center'>Se ainda não é cadastrado</Typography>
                <a href="">Clique aqui</a>
            </Box>
        </Box>
    );
};

export default LoginForm;