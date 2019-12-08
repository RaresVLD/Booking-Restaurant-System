import styled from 'styled-components';


export const TitleAndDescriptionContainer: any = styled.div`
    display: flex;
    flex-direction: column;
    justify-content: flex-start;
    width: 100%;
    border-bottom-width: 0.5px;
    border-bottom-style: solid;
    border-bottom-color: rgb(100,100,100);
    overflow-wrap: break-word;
    
`;

export const Title: any = styled.p`
    font-size: 24px;
    font-weight: 700;
    padding-top: 10px;
    margin: 0 auto;
    color: white;
`;

export const Description: any = styled.p`
    font-size: 18px;
    margin-left: 30px;
    margin-right: 30px;
    margin-bottom: 10px;
    color: white;
`;


export const MenuScrollView: any = styled.div`
    display: flex;
    flex-direction: column; 
    overflow-y:scroll;
    scrollbar-track-color: blue;
`;

export const ProductAndAdd: any = styled.div`
    margin-top: 20px;
    display: flex;
    flex-direction: row;
    width: 90%;
    margin: auto;
    justify-content: flex-end;
    align-items: flex-end;
`;