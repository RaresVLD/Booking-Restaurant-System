import styled from 'styled-components';

export const MenuAndCommandControllerContainer: any = styled.div`
    display: flex;
    justify-content: space-between;
    align-items: center;
    flex-direction: row;
    width: 100%;
    height: 93.5%;
    overflow: hidden;
    border-width: 1px;
    border-color: rgb(100,100,100);
    border-style: solid;
`;

export const MenuContainer: any = styled.div`
    width: 80%;
    height: 100%;
    background-color: transparent;
    opacity: 0.9;
    display: flex;
    flex-direction: column;
    align-self: center;
    overflow: hidden; 
    border-right-width: 1px;
    border-right-color: rgb(100,100,100);
    border-right-style: solid;
  
`;

export const ControllerContainer: any = styled.div`
    width: 20%;
    height: 100%;
    border-left-width: 1px;
    border-left-color: rgb(100,100,100);
    background-color: rgb(50,50,50);
`;