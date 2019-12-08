import * as React from 'react';
import { DashBoardContainer } from '../dashboard/dashboard.style';
import { AppHeader } from '../shared/app-header';
import { MyReservationsMenu, SingleReservationDetails, Order, OrderInformation, MyReservationsTitle, ReservationTitle } from './my-reservations.style';

interface Props {

}

interface State {
    orders: number[]
    orderToDisplay: string;
}

export class MyReservations extends React.Component<Props, State> {
    constructor(props: Props) {
        super(props);

        this.state = {
            orders: [1,2,34,5,6,7,8,9,10,11,12,13,14,15,16,17, 18, 19, 20] as number[],
            orderToDisplay: '' as string,
        } as State;
    }

 public render() {
     const { orders } = this.state; 
     return(
        <DashBoardContainer>
            <AppHeader />

            <MyReservationsMenu>
                <MyReservationsTitle>
                    <ReservationTitle>
                        My Reservations
                    </ReservationTitle>
                </MyReservationsTitle>
            
               {
                   orders.map((order) => 
                   <Order onClick={() => this.onOrderNumberPress(order)}>
                       order number {order}
                   </Order>)
               }

            </MyReservationsMenu>

               {
                   !!this.state.orderToDisplay &&
                   <SingleReservationDetails>
                       <OrderInformation>
                           {this.state.orderToDisplay}
                       </OrderInformation>
                   </SingleReservationDetails>
               }
                

        </DashBoardContainer>
        )
 }

    public componentDidMount() {
        
    }

    public onOrderNumberPress(orderNo: number) {
        this.setState({
            orderToDisplay: `you chose order with number: ${orderNo}`,
        })
    }
}