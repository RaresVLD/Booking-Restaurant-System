import * as React from 'react';
import { MenuContainer } from '../restaurant.style';
import { TitleAndDescriptionContainer, Title, Description, ProductAndAdd } from './menu.style';
import { Products } from './product';
import { Product } from '../../interfaces/interfaces';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { IconContainer } from './product.style';
import { faPlus } from '@fortawesome/free-solid-svg-icons';

interface Props {
    restaurantMenuDescription: string;
    restaurantName: string;
    onAddPress: (id: string) => void 
}

interface State {
    restaurantMenu: Product[];
}

export class Menu extends React.Component<Props, State> {
    constructor(props: Props) {
        super(props);
        this.state = {
            restaurantMenu: [] as Product[],
        }
    }


    public render() {
        return (
            <MenuContainer>
                <TitleAndDescriptionContainer>
                    <Title>
                        {this.props.restaurantName}
                    </Title>

                    <Description>
                        {this.props.restaurantMenuDescription}
                    </Description>
                </TitleAndDescriptionContainer>
                <div style={{ display: 'flex', flexDirection: 'column', overflowY: 'scroll' }}>
                    {
                        this.state.restaurantMenu.map((product, index) => {

                            return (
                                <ProductAndAdd key={index}>
                                    <Products
                                        product={product} />
                                    <IconContainer>
                                        <FontAwesomeIcon
                                            onClick={() => this.props.onAddPress(product.id)}
                                            style={{ position: 'relative', right: '20px', bottom:'30px', 
                                                cursor: 'pointer', width: 20, height: 20, color: 'orange' }}
                                            icon={faPlus} />
                                    </IconContainer>
                                </ProductAndAdd>
                            )
                        }
                        )
                    }
                </div>
            </MenuContainer>
        )
    }

    public async componentDidMount() {
        let urlParams = window.location.pathname;

        let restaurantPath = urlParams.split('/');


        const restaurantMenu = await fetch(`https://localhost:44367/v1/restaurants/name/${restaurantPath[2]}/products`)
        restaurantMenu
            .json()
            .then(restaurantMenu => this.setState({ restaurantMenu }))
            .catch(err => console.log('+++ error', err));
    }
;}