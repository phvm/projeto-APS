import React from 'react';
import loginImg from '../../assets/loginImg.svg';
import { Box, Typography } from '@mui/material'
import LoginForm from '../../Components/LoginForm';

const LoginScreen = () => {
    return(
        <Box sx={{width: '100vw', height: '100vh', backgroundColor: '#05D5B2', display: 'flex'}}>
            <Box sx={{width: '60%', height: '80%', display: 'flex', flexDirection: 'column', justifyContent: 'space-around', alignItems: 'center'}}>
                <Typography align='center' variant='h1' sx={{color: '#f2f0f0'}}>
                    VaCInnação
                </Typography>
                <img src={loginImg} alt="" style={{width: '600px', height: '500px'}}/>
            </Box>
            <Box sx={{width: '40%', height: '80%', display: 'flex', justifyContent: 'flex-start', alignItems: 'center', marginTop: '3.5em'}}>
                <Box sx={{width: '80%', height: '100%', backgroundColor: '#F2F0F0', borderRadius: '2em'}}>
                    <LoginForm />
                </Box>
            </Box>
        </Box>
    );
;}

export default LoginScreen;