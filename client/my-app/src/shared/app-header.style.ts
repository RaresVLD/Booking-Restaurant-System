import styled from 'styled-components';
import { colors } from './colors';


export const BOX_SHADOW_CSS = 'box-shadow: 0px 0px 16px rgba(0,0,0,0.2)';

export const AppHeaderStyle: any = styled.div`
    z-index: 101;
    display: flex;
    flex-direction: row;
    align-items: center;
    justify-content: space-between;
    height: 60px;
    width: 100vw;
    min-width: 800px;
    ${BOX_SHADOW_CSS};
    background-color: #000000;
    background-image: linear-gradient(315deg, #000000 0%, #414141 74%);
    position: sticky;
    top:0px;
`;

export const LogoContainer: any = styled.div`
    margin-left: 20px;
    justify-content: center;
    align-items: center;
    flex-direction: row;
    display: flex;
    margin-top: 5px;
    cursor: pointer;
`;

export const LoginText: any = styled.p`
    font-size: 18px;
    color: white;
    color: ${colors.charcoal};
    font-weight: 500;
`;