import styled from 'styled-components';

export const MyReservationsMenu: any = styled.div`
    margin-top: 10px; 
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    width: 250px;
`;

export const SingleReservationDetails: any = styled.div`
    position: absolute;
    /* right: 25%; */
    top: 50%;  /* position the top  edge of the element at the middle of the parent */
    left: 50%; /* position the left edge of the element at the middle of the parent */
    transform: translate(-30%, -50%);
    width: 35%;
    height: 300px;
    border-color: white;
    border-width: 1px;
    border-style: solid;
`;

export const Order: any = styled.p`
    cursor: pointer;
    font-size: 18px;
    color: white;
`;

export const OrderInformation: any = styled.p`
    font-size: 16px;
    color: white;
`;

export const MyReservationsTitle: any = styled.div`
    width: 100%;
    height: 50px;
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    border-bottom-color: white;
    border-bottom-width: 0.5px;
    border-bottom-style: solid;
`;

export const ReservationTitle: any = styled.p`
    font-size: 20px;
    color: white;
    font-weight: 500;
`;