import * as React from 'react';
import { HomePageContainer, BoxContainer, LoginContent, LogoContainer, StyledInput, Input, InputsContainer, StyledButton, SwitchButtonContainer, SwitchButton, SignUpInputsContainer, BackgroundImage } from './home-page.style';

interface Props {

}

interface State {
    status: number;
    loginUsername: string;
    loginPassword: string;
    signUpFN: string;
    signUpLN: string;
    signUpEmail: string;
    signUpPassword: string;
    signUpRepeat: string;
    res: any;
}


export class HomePage extends React.Component<Props, State> {
    constructor(props: Props) {
        super(props);

        this.state = {
            status: 0,
            loginUsername: '',
            loginPassword: '',
            signUpFN: '',
            signUpLN: '',
            signUpUser: '',
            signUpEmail: '',
            signUpPassword: '',
            signUpRepeat: '',
            res: '',
        } as State;
    }




    public render() {
        console.log('+++ this.state', this.state);
        const { status } = this.state;
        return (
            <HomePageContainer>
                <BackgroundImage/>
                {/* <DarkBackgroundOverlay/> */}
                <BoxContainer>
                    <LoginContent>
                        <>
                        <LogoContainer>
                            <img alt={'logo'}
                                src={require('../images/logonew.png')} />
                        </LogoContainer>
                        {
                            status === 0 ?
                                <InputsContainer>
                                    <StyledInput>
                                        <Input
                                            onChange={(event: Event) => this.handleTextChange(event, 'loginUsername')}
                                            placeholder={'Username'}
                                            type="text"
                                            value={this.state.loginUsername}

                                        />
                                    </StyledInput>

                                    <StyledInput>
                                        <Input
                                            onChange={(event: Event) => this.handleTextChange(event, 'loginPassword')}
                                            placeholder={'Password'}
                                            type="password"
                                            value= {this.state.loginPassword}
                                        />
                                    </StyledInput>
                                </InputsContainer>
                                :
                                <SignUpInputsContainer>
                                    <StyledInput>
                                        <Input
                                        onChange={(event: Event) => this.handleTextChange(event, 'signUpFN')}
                                            placeholder='First Name'
                                            type="text"
                                            value={this.state.signUpFN}
                                        />
                                    </StyledInput>

                                    <StyledInput>
                                        <Input
                                            onChange={(event: Event) => this.handleTextChange(event, 'signUpLN')}
                                            placeholder='Last Name'
                                            type="text"
                                            value={this.state.signUpLN}
                                        />
                                    </StyledInput>
                                    <StyledInput>
                                        <Input
                                            onChange={(event: Event) => this.handleTextChange(event, 'signUpEmail')}
                                            placeholder={'Email'}
                                            type="text"
                                            value={this.state.signUpEmail}
                                        />
                                    </StyledInput>

                                    <StyledInput>
                                        <Input
                                            onChange={(event: Event) => this.handleTextChange(event, 'signUpPassword')}
                                            placeholder={'Password'}
                                            type="password"
                                            value={this.state.signUpPassword}
                                        />
                                    </StyledInput>
                                    <StyledInput>
                                        <Input
                                            onChange={(event: Event) => this.handleTextChange(event, 'signUpRepeat')}
                                            placeholder={'Repeat Password'}
                                            type="password"
                                            value={this.state.signUpRepeat}
                                        />
                                    </StyledInput>
                                </SignUpInputsContainer>

                        }


                        <StyledButton
                        onClick={() => window.location.replace('/dashboard')}
                        >
                            {
                                status === 0 ?
                                    'Login' :
                                    'Sign Up'
                            }
                        </StyledButton>

                            </>    
                        <SwitchButtonContainer>
                        <SwitchButton
                            status={this.state.status}
                            onClick={() => this.onSignInPress()}
                            direction='left'>
                            Sign In
                        </SwitchButton>
                        <SwitchButton
                            status={this.state.status}
                            onClick={() => this.onSignOutPress()}
                            direction='right'>
                            Sign Up
                        </SwitchButton>
                    </SwitchButtonContainer>
                    </LoginContent>
                    
                </BoxContainer>
            </HomePageContainer>
        )
    }

    public async componentDidMount() {
        this.setState({
            status: 0,
        })

        const res = await fetch("https://localhost:44367/v1/users");
        res
          .json()
          .then(res => this.setState({res}))
          .catch(err => console.log('+++ err', err));

        
        
        
    }

    private onSignInPress() {
        this.setState({
            status: 0
        })
    }

    private onSignOutPress() {
        this.setState({
            status: 1
        })
    }

    handleTextChange(event: any, type: string) {
        this.setState({
            ...this.state,
            [type]: event.target.value
        });
    }
}