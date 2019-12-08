import { createBrowserHistory } from 'history';
import { Link, NavLink } from 'react-router-dom';
import styled from 'styled-components';

/** TODO Document why we have this file. */
export {
    BrowserRouter as Router,
    Switch,
    Route,
    Link,
    NavLink,
} from 'react-router-dom';

let style = `
    text-decoration: none;

    &:focus, &:hover, &:visited, &:link, &:active {
        text-decoration: none;
    }

    &:hover div {
        color: 'cyan';
    }
`;

export const StyledLink = styled(Link)`${style}`;
export const NavStyledLink = styled(NavLink)`${style}`;

export let history = createBrowserHistory();