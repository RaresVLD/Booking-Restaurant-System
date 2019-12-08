import styled from 'styled-components';

export const MyReservationContainer: any = styled.div`
    display: flex;
    flex-direction: column;
    height: 5%;
    width: 100%;
    justify-content: center;
    align-items: center;
    border-bottom-color: rgb(100,100,100);
    border-bottom-width: 1px;
    border-bottom-style: solid;
`;

export const MyReservationText: any = styled.p`
    color: white;
    font-size: 20px;
    margin: auto;
`;

export const MyReservationSetting: any = styled.div`
    display: flex;
    flex-direction: column;
    height: 15%;
    width: 100%;
    justify-content: space-between;
    padding: 20px;
    border-bottom-color: rgb(100,100,100);
    border-bottom-width: 3px;
    border-bottom-style: solid;
`;

export const ReservationSettingsText: any = styled.p`
    padding: 0;
    margin: 0;
    color: white;
    font-size: 16px;
`;

export const MyOrder: any = styled.div`
    overflow-y: scroll;
    display: flex;
    flex-direction: column;
    justify-content: flex-start;
    align-items: center;
    padding: 20px;
    width: 100%;
    height: 70%;
`;

export const SubmitCommand: any = styled.div`
    width: 150px;
    text-align: center;
    font-weight: 600;
    margin-top: 50px;
    border-radius: 5px;
    height: 40px;
    color: white;
    background-color: rgb(100,100,100);
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    cursor: pointer;
`;

export const Input: any = styled.input`
    width: 50px;
    height: 25px;
    border-radius: 5px;
    font-family: 'Gotham SSm A', 'Gotham SSm B';
    font-size: 16px;
    font-weight: 600;
    line-height: normal;
    background-color: transparent;
    color: white;
    outline: none;
    -webkit-appearance: none;
    text-align: center;
`;


export const StyledInput: any = styled.div`
    width: 50px;
    height: 25px;
    transition: 0.3s all;
`;
