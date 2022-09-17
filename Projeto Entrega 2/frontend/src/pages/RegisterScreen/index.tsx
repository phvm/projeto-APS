import { Box, Typography } from '@mui/material';
import registerImg from '../../assets/registerImg.svg';
import RegisterForm from '../../Components/RegisterForm';

const RegisterScreen = () => {
    return(
        <Box sx={{width: '100vw', height: '100vh', backgroundColor: '#05D5B2', display: 'flex'}}>
            <Box sx={{width: '60%', height: '80%', display: 'flex', flexDirection: 'column', justifyContent: 'space-between', alignItems: 'center', marginTop:'5.5em'}}>
                <Typography align='center' variant='h1' sx={{color: '#f2f0f0', fontSize: '6rem'}}>
                    vaCInnação
                </Typography>
                <img src={registerImg} alt="" style={{width: '60%', height: '80%'}} />
            </Box>
            <Box sx={{width: '40%', height: '100%', display: 'flex', justifyContent: 'left', alignItems: 'center'}}>
                <RegisterForm />
            </Box>
        </Box>
    );
};

export default RegisterScreen;