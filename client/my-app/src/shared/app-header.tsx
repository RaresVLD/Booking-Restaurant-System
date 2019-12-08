import * as React from 'react';
import { AppHeaderStyle, LogoContainer } from './app-header.style';
import { DashBoardButtonsContainer, DashBoardButton1, DashboardButton2, DashboardButton3} from '../dashboard/dashboard.style';
import { faWindowClose } from '@fortawesome/free-solid-svg-icons';

interface Props { 

}

interface State {
    myReservationsHover: boolean;
    historyHover: boolean;
    logoutHover: boolean;
}

export class AppHeader extends React.Component<Props, State> {

    constructor(props: Props) {
        super(props);

        this.state = {
            myReservationsHover: false,
            historyHover: false,
            logoutHover: false,
        } as State;
    }

    public render() {
        return (
            <AppHeaderStyle>
                <LogoContainer onClick={() => window.location.replace('/dashboard')}>
                    <img alt={'logo'} width='160' height='70'
                    src= { require('../images/logonew.png') } />
                </LogoContainer>
                <DashBoardButtonsContainer>
                    <DashBoardButton1
                        onClick = {() => window.location.replace('/my-reservations')}
                        myReservationHover = {this.state.myReservationsHover}
                        onMouseEnter = {(e: any) => this.onMouseEnterAction(e)}
                        onMouseLeave = {(e: any) => this.onMouseLeaveAction(e)}
                        value = 'my_reservations'>
                        My Reservations
                    </DashBoardButton1>
                    
                    <DashboardButton2
                        historyHover = {this.state.historyHover}
                        onMouseEnter = {(e: any) => this.onMouseEnterHistory(e)}
                        onMouseLeave = {(e: any) => this.onMouseLeaveHistory(e)}
                        value = 'history'>
                        History
                    </DashboardButton2>
                    
                    <DashboardButton3
                        logoutHover = {this.state.logoutHover}
                        onMouseEnter = {(e: any) => this.onMouseEnterLogout(e)}
                        onMouseLeave = {(e: any) => this.onMouseLeaveLogout(e)}
                        value = 'logout'>
                        Logout
                    </DashboardButton3>
                </DashBoardButtonsContainer>
            </AppHeaderStyle>
        )
    }

    public componentDidMount() {

    }

    private onMouseEnterAction(_event: any) {
        this.setState({
            myReservationsHover: true,
        })

    }

    private onMouseLeaveAction(_event: any ) {
        this.setState({
            myReservationsHover: false,
        })
    }

    private onMouseEnterHistory(_event: any) {
        this.setState({
            historyHover: true,
        })

    }

    private onMouseEnterLogout(_event: any ) {
        this.setState({
            logoutHover: true,
        })
    }

    private onMouseLeaveLogout(_event: any) {
        this.setState({
            logoutHover: false,
        })

    }

    private onMouseLeaveHistory(_event: any ) {
        this.setState({
            historyHover: false,
        })
    }

}
