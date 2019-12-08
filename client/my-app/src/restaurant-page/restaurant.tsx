import * as React from 'react';
import { AppHeader } from '../shared/app-header';
import { DashBoardContainer2 } from '../dashboard/dashboard.style';
import { MenuAndCommandControllerContainer } from './restaurant.style';
import { Menu } from './components/menu';
import { CommandController } from './components/command-controller';
import { Restaurant_ts, Order, Product } from '../interfaces/interfaces';

interface Props {

}

interface State {
    restaurants: Restaurant_ts;
    productsToOrder: Order[];
    restaurantApi: Restaurant_ts[];
    restaurantul: Restaurant_ts;
    restaurantMenu: Product[];
}

export class Restaurant extends React.Component<Props, State> {
    constructor(props: Props) {
        super(props);

        this.state = {
            restaurants: {
            } as Restaurant_ts,
            productsToOrder: [] as Order[],
            restaurantApi: [] as Restaurant_ts[],
            restaurantMenu: [] as Product[],
            restaurantul: {} as Restaurant_ts,
        }
    }

    public render() {
        console.log('+++ this.state.resaurantul', this.state.restaurantul);
        const { productsToOrder } = this.state;

        return (
            <DashBoardContainer2>
                <AppHeader />
                <MenuAndCommandControllerContainer>
                    <Menu
                        onAddPress={(id: string) => this.AddProductToCommand(id)}
                        restaurantMenuDescription={this.state.restaurantul.description}
                        restaurantName={this.state.restaurantul.name}
                         />
                    <CommandController productsToOrder={productsToOrder} />
                </MenuAndCommandControllerContainer>
            </DashBoardContainer2>
        )
    }

    public async componentDidMount() {
        let urlParams = window.location.pathname;

        let restaurantPath = urlParams.split('/');
        const restaurant = await fetch(`https://localhost:44367/v1/restaurants/name/${restaurantPath[2]}`)
        restaurant
            .json()
            .then(restaurant => this.setState({ restaurantul: restaurant }))
            .catch(err => console.log('+++ err', err))

            const restaurantMenu = await fetch(`https://localhost:44367/v1/restaurants/name/${restaurantPath[2]}/products`)
            restaurantMenu
                .json()
                .then(restaurantMenu => this.setState({ restaurantMenu }))
                .catch(err => console.log('+++ error', err));

    }

    private AddProductToCommand(id: string) {

        
        let ok = 0;
        const { productsToOrder } = this.state;

        if (!!productsToOrder) {
            productsToOrder.forEach(product => {
                if (product.product.id === id) {
                    product.noOfProducts = product.noOfProducts + 1;
                    ok = 1;
                }
            })

        }
        if (ok === 0) {
            let newProduct: any = this.state.restaurantMenu.find(product => product.id === id);

            let orderProudct: Order = {
                product: newProduct,
                noOfProducts: 1,
            }

            productsToOrder.push(orderProudct);

            this.setState({
                productsToOrder: productsToOrder,
            })
        } else {
            this.setState({
                productsToOrder: productsToOrder,
            })
        }
    }
}