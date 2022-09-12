import React from 'react';
import loginImg from '../../assets/loginImg.svg';
import { Box, Typography } from '@mui/material'

const Login = () => {
    return(
        <Box sx={{width: '100vw', height: '100vh', backgroundColor: '#05D5B2'}}>
            <Box sx={{width: '60%', display: 'flex', flexDirection: 'column', alignItems: 'center'}}>
                <Typography align='center' variant='h1'>
                    VaCInnação
                </Typography>
                <img src={loginImg} alt="" />
            </Box>
            <Box sx={{width: '40%'}}>
            </Box>
        </Box>
    );
;}

export default Login();