import * as React from 'react';
import { DashBoardContainer, RestaurantsContainer, Restaurant, RestaurantImage, RestaurantData, RestaurantName, RestaurantDescription, RestaurantDetailsButtonContainer,RestaurantDetailsButton } from './dashboard.style';
import { AppHeader } from '../shared/app-header';
import { Restaurant_ts } from '../interfaces/interfaces';

interface Props {

}

interface State {
    restaurantsApi: Restaurant_ts[];
}


export class DashBoard extends React.Component<Props, State> {
    constructor(props: Props) {
        super(props);
        
        this.state = {
            restaurantsApi: [] as Restaurant_ts[], 
        } as State;
    }



    public render() {
        return (
            <DashBoardContainer>
                <AppHeader/>
                <RestaurantsContainer>
                    {
                        this.state.restaurantsApi.map(restaurant => {
                            
                            return (
                                <Restaurant key = {restaurant.id}>
                                <RestaurantImage>
                                    <img alt='lorem ipsum' 
                                    src={require('../shared/background-image.png')} width="100%" height="350px"/>
                                </RestaurantImage>
                                <RestaurantData>
                                    <RestaurantName>
                                        {restaurant.name}
                                    </RestaurantName>
                                    <RestaurantDescription>
                                        {restaurant.description}
                                    </RestaurantDescription>
                                    <RestaurantDetailsButtonContainer>
                                        <RestaurantDetailsButton
                                        onClick = {() => window.location.replace(`/restaurant/${restaurant.name}`)}
                                        >
                                            Check out
                                        </RestaurantDetailsButton>
                                    </RestaurantDetailsButtonContainer>
                                </RestaurantData>
                            </Restaurant>
                            )
                        })
                    }
                    
                </RestaurantsContainer>
            </DashBoardContainer>
        );
    }

    public async componentDidMount() {
        const res = await fetch("https://localhost:44367/v1/restaurants");
            res
                .json()
                .then(res => this.setState({restaurantsApi: res}))
                .catch(err => console.log('+++ err', err))
    }
            
}