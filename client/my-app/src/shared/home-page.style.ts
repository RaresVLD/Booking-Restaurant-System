import styled from 'styled-components';
import { colors } from './colors';
import  backgroundImg  from './food-back.jpeg';
export const BOX_SHADOW_CSS = 'box-shadow: 0px 0px 16px rgba(150,150,150,0.9)';


export const HomePageContainer: any = styled.div`
    width: 100%;
    height: 100%;
    display: flex;
    justify-content: center;
    align-items: center;
    flex-direction: column;
    position: relative;
    
`;

export const BackgroundImage: any = styled.div`
    display: flex;
    flex-direction: column;
    position: absolute;
    width: 100%;
    height: 100%;
    background-size: cover;
    background-image: url(${backgroundImg});
    /** Keep bgr image centered on window resize */
    background-position: center center;
    background-repeat: no-repeat;
    z-index: -1;
`;

export const LoginContent: any = styled.div`
    opacity: 0.95;
    display: flex;
    flex-direction: column;
    justify-content: space-between;
    /* justify-content: space-between; */
    /* align-items: center; */
    background-color: white;
    width: 100%;
    height: 100%;
    border-radius: 15px;
    align-items: center;
`;


export const BoxContainer: any = styled.div`
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    width: 400px;
    height: 600px;
    ${BOX_SHADOW_CSS};
    border-radius: 20px;
    border-width: 1px;
    border-color: transparent;
`;

export const ImageContainer: any = styled.div`
    align-self: center;
`;

export const LogoContainer: any = styled.div`
    margin-top: 50px;
`;


export const Input: any = styled.input`
    width: 220px;
    height: 35px;
    border-radius: 4px;
    font-family: 'Gotham SSm A', 'Gotham SSm B';
    font-size: 16px;
    font-weight: 600;
    line-height: normal;
    background-color: transparent;
    color: #282828;
    outline: none;
    -webkit-appearance: none;
    text-align: center;
`;


export const StyledInput: any = styled.div`
    align-self: center;
    width: 220px;
    height: 35px;
    border-radius: 4px;
    background-color: rgba(255,255,255,0.3);
    transition: 0.3s all;
`;

export const InputsContainer: any = styled.div`
    margin-top: 80px;;
    align-self: center;
    display: flex;
    flex-direction: column;
    justify-content: space-between;
    height: 105px;
`;


export const StyledButton: any = styled.button`
    color: white;
    text-decoration: none;
    border-radius: 5px;
    border: none;
    margin-top: 30px;
    transition: all 0.4s ease 0s;
    width: 120px;
    height: 40px;
    background-color: #000000;
    background-image: linear-gradient(315deg, #000000 0%, #414141 74%);
    cursor: pointer;
    `;

export const SwitchButtonContainer: any = styled.div`
    width: 100%;
    height: 50px;
    border-radius: 0px 0px 5px 5px;
    position: relative;
    bottom: 0px;
    display:flex;
    flex-direction: row;
`;

export const SwitchButton: any = styled.button`
    margin-top:1px;
    width: 50%;
    height: 100%;
    text-decoration: none;
    /* border-radius: 0px 0px 0px 5px; */
    ${(props:any) => decideBorder(props.direction, props.status)}
    /* border-color: rgb(150,150,150); */
    transition: all 0.s ease 0s;
    box-sizing: border-box;
    outline-style: none;
    border: none;
    cursor: pointer;
`; 

export const SignUpInputsContainer: any = styled.div`
    /* margin-top: ; */
    align-self: center;
    display: flex;
    flex-direction: column;
    justify-content: space-between;
    height: 260px;
`;


function decideBorder(direction: string, status: number) {
    if(status === 0 ) {
        if(direction === 'left'){
            return `
            color: white;
            background-color: #000000;
            background-image: linear-gradient(315deg, #000000 0%, #414141 74%);
                border-radius: 0px 0px 0 5px;
             `
        }else if(direction === 'right'){
            return `
                background-color: ${colors.charcoal}
                border-radius: 0px 0px 5px 0px;
             `
        }

    }

    else if (status === 1){
        if(direction === 'right'){
            return `
            color: white;
            background-color: #000000;
            background-image: linear-gradient(315deg, #000000 0%, #414141 74%);
                border-radius: 0px 0px 5px 0px;
             `
        }else if(direction === 'left'){
            return `
                background-color: none;
                border-radius: 0px 0px 0px 5px;
             `
        }
    }
    
}