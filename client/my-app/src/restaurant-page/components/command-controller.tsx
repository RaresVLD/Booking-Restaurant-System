import * as React from 'react';
import { ControllerContainer } from '../restaurant.style';
import { MyReservationContainer, MyReservationText, MyReservationSetting, ReservationSettingsText, MyOrder, SubmitCommand, StyledInput, Input } from './command-controller.style';
import DatePicker from 'react-date-picker';
import { Order } from '../../interfaces/interfaces';

interface Props {
    productsToOrder: Order[];
}

interface State {
    date: Date;
    time: string;
    noOfPersons: string;
}

export class CommandController extends React.Component<Props, State> {
    constructor(props: Props) {
        super(props);

        this.state = {
            date: new Date(),
            time: '',
            noOfPersons: '0',
        } as State;
    }

    public options = {
        label1: '8:00',
        label2: '9:00'
    }




    onChange = (date: any) => this.setState({ date })
    public render() {
        console.log('+++ time', this.state.time);
        const { productsToOrder } = this.props;
        return (
            <ControllerContainer>
                <MyReservationContainer>
                    <MyReservationText>
                        My reservation
                    </MyReservationText>
                </MyReservationContainer>


                <MyReservationSetting>
                    {/* <ReservationSettingsText> number of people</ReservationSettingsText> */}
                    <div style={{
                        display: 'flex', flexDirection: 'row', alignItems: 'flex-start',
                        width: '300px'
                    }}>

                        <div style={{ backgroundColor: 'white' }}>
                            <DatePicker
                                onChange={this.onChange}
                                value={this.state.date}
                            />
                        </div>


                    </div>

                    <div style={{width:'100px'}}>
                    <input
                        type="time"
                        step="1"
                        value={this.state.time}
                        className="form-control"
                        placeholder="Time"
                        onChange={(ev) => this.setState({ time: ev.target.value })}
                    />
                     </div>

                    <div style={{
                        display: 'flex', flexDirection: 'row', alignItems: 'center',
                        width: '115px', justifyContent: 'space-between'
                    }}>




                        <ReservationSettingsText>
                            Persons:
                        </ReservationSettingsText>
                        <StyledInput>
                            <Input
                                onChange={(event: Event) => this.handleTextChange(event, 'noOfPersons')}
                                type="number"
                                value={this.state.noOfPersons}
                                min={0}
                            />
                        </StyledInput>
                    </div>



                    {/* <ReservationSettingsText> hour </ReservationSettingsText> */}
                </MyReservationSetting>


                <MyReservationContainer>
                    <MyReservationText>
                        My Order
                    </MyReservationText>
                </MyReservationContainer>

                <MyOrder>
                    {
                        !!productsToOrder && productsToOrder.map((product) => 
                            <p style={{color: 'white'}}>
                                {product.noOfProducts} x {product.product.name}
                            </p>
                        ) 
                                           }


                    <SubmitCommand
                    >
                        Place Order
                </SubmitCommand>
                </MyOrder>



            </ControllerContainer>
        )
    }

    handleTextChange(event: any, type: string) {
        this.setState({
            ...this.state,
            [type]: event.target.value
        });
    }
}

