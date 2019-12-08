import * as React from 'react';
import { ProductContainer, TitleContainer, Title, DescriptionContainer, Description, PriceAndAdd, PriceContainer, Price } from './product.style';
import { Product } from '../../interfaces/interfaces';

interface Props {
    product: Product
}

interface State {

}

export class Products extends React.Component<Props, State> {
    constructor(props: Props) {
        super(props);

        this.state = {

        } as State;
    }

    public render() {
        const { product } = this.props;
        return (
            <ProductContainer>
                <TitleContainer>
                    <Title>
                        {product.name}
                    </Title>
                </TitleContainer>

                <DescriptionContainer>
                    <Description>
                        {product.description}
                    </Description>
                </DescriptionContainer>

                <PriceAndAdd>
                    <PriceContainer>
                        <Price>
                            {product.price} Lei
                        </Price>
                    </PriceContainer>

                </PriceAndAdd>
            </ProductContainer>
        );
    }
}