import styled from 'styled-components';
import { BOX_SHADOW_CSS } from '../shared/home-page.style';

export const DashBoardContainer: any = styled.div`
    width: 100%;
    height: 100%;
    overflow-x: hidden;
    background-color: #000000;
background-image: linear-gradient(315deg, #000000 0%, #414141 74%);
`;

export const DashBoardContainer2: any = styled.div`
    width: auto;
    height: 100%;
    display :flex;
    flex-direction: column;
    overflow-x: hidden;
    background-color: #000000;
    background-image: linear-gradient(315deg, #000000 0%, #414141 74%);
`;

export const DashBoardButtonsContainer: any = styled.div`
    display: flex;
    flex-direction: row;
    height: 100%;
`;

export const DashBoardButton1: any = styled.div`
    width: 150px;
    text-align: center;
    height: 100%;
    align-items: center;
    justify-content: center;
    display: flex;
    color: white;
    flex-direction: column;
    cursor: pointer;
     font-weight: ${(props: any) => props.myReservationHover ? 600 : 100};
     ${(props: any) => props.myReservationHover && BOX_SHADOW_CSS  }
     `;

export const DashboardButton2: any = styled.div`
    width: 150px;
    text-align: center;
    height: 100%;
    color: white;
    align-items: center;
    justify-content: center;
    display: flex;
    flex-direction: column;
    cursor: pointer;
    font-weight: ${(props: any) => props.historyHover ? 600 : 100};
    ${(props: any) => props.historyHover && BOX_SHADOW_CSS  }
`;

export const DashboardButton3: any = styled.div`
    width: 150px;
    text-align: center;
    height: 100%;
    align-items: center;
    justify-content: center;
    color: white;
    display: flex;
    flex-direction: column;
    cursor: pointer;
     font-weight: ${(props: any) => props.logoutHover ? 600 : 100};
     ${(props: any) => props.logoutHover && BOX_SHADOW_CSS  }
`;

export const RestaurantsContainer: any = styled.div`
    margin: 0 auto;
    margin-top: 100px;
    height: auto;
    width: 1200px;
`;

export const Restaurant: any = styled.div`
    margin: 50px auto;
    width: 100%;
    height: 350px;
    box-shadow: 6px 9px 22px -8px rgba(0,0,0,0.75);
    display: flex;
    flex-direction: row;
    border-radius: 30px;   
    background-color: white;  
`;

export const RestaurantImage: any = styled.div`
    width: 40%;
    height: 350px;
`;

export const RestaurantData: any = styled.div`
    float: right;
    height: 100%;
    width: 60%;
    display:flex;
    flex-direction: column;
`;

export const RestaurantName: any = styled.div`
    height: 20%;
    text-align: center;
    display:flex;
    flex-direction: column;
    align-items: center;
    justify-content: center;
    font-weight: 700;
    font-size: x-large;
    font-family: 'New Century Schoolbook, TeX Gyre Schola, serif';
`;

export const RestaurantDescription: any = styled.div`
    height: 60%;
    text-align: left;
    padding: 20px;
    font-size: large;
    font-family:  'Open Sans';
`;

export const RestaurantDetailsButtonContainer: any = styled.div`
    height: 20%;
`;

export const RestaurantDetailsButton: any = styled.button`
    width: 150px;
    height: 50px;
    float: right;
    margin: 10px;
    border: none;
    color: white;
    border-radius: 30px;
    background-color: #000000;
    background-image: linear-gradient(315deg, #000000 0%, #414141 74%);
    outline-style:none;
    cursor: pointer;
`;