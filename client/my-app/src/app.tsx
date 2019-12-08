import * as React from 'react';
import { withRouter, Switch, Route } from 'react-router';
import { Application, SafeArea, Content } from './app.style';
// import { AppHeader } from './shared/app-header';
import { HomePage } from './shared/home-page';
import { DashBoard } from './dashboard/dashboard';
import { Restaurant } from './restaurant-page/restaurant';
import { MyReservations } from './reservations/my-reservations';

interface Props {

}

interface State {

}


export class App extends React.Component<Props, State> {
    constructor(props: Props) {
        super(props);

        this.state = {

        }
    }

    public render( ) {
        return (
            <Application>
                <SafeArea>
                    {/* <AppHeader />  */}
                    
                    <Content>
                        <Switch>
                            <Route exact={true} path='/' component={HomePage}/>
                            <Route exact={true} path='/dashboard' component={DashBoard}/>
                            <Route exact={true} path='/restaurant/:restaurant_id' component={Restaurant} />
                            <Route exact={true} path='/my-reservations' component={MyReservations} />
                        </Switch>
                    </Content>                    


                </SafeArea>
            </Application>
            
        );
    }
}

export default withRouter<any, any>(App);