export interface Restaurant_ts {
    id: string;
    name: string;
    description: string;
    address?: string;
    products?: Product[]
    menu: Menu
}

export interface Menu {
    id_menu: number;
    description: string;
    products: Product[];
}

export interface Product {
    restaurant_id?: any;
    id: any;
    name: string;
    description: string;
    price: number;
}

export interface Order {
    product: Product;
    noOfProducts: number;
}