import { Form, Grid, Header, Icon, Message, Segment } from 'semantic-ui-react'

import { Link } from 'react-router-dom'

const Register = () => {
  return (
    <Grid textAlign="center" verticalAlign="middle" className="app">
      <Grid.Column style={{ maxWidth: 450 }}>
        <Header as="h1" icon color="teal" textAlign="center">
          <Icon name="user circle" />
          Register
        </Header>
        <Form size="large">
          <Segment stacked>
            <Form.Input
              fluid
              name="username"
              placeholder="Username"
              icon="user"
              iconPosition="left"
            />
            <Form.Input
              fluid
              name="email"
              type="email"
              placeholder="Username"
              icon="mail"
              iconPosition="left"
            />
            <Form.Input
              type="password"
              fluid
              name="password"
              icon="lock"
              iconPosition="left"
              placeholder="Password"
            />
            <Form.Input
              type="password"
              fluid
              name="passwordConfirmation"
              icon="repeat"
              iconPosition="left"
              placeholder="Password Confirmation"
            />
            <Form.Button color="teal" fluid size="large">
              Sign up
            </Form.Button>
          </Segment>
        </Form>
        <Message>
          Already have an account? <Link to="/auth/login">Sign in</Link>
        </Message>
      </Grid.Column>
    </Grid>
  )
}

export default Register
