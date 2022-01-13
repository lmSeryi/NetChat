import { Form, Grid, Header, Icon, Message, Segment } from 'semantic-ui-react'

import { Link } from 'react-router-dom'

const Login = () => {
  return (
    <Grid textAlign="center" verticalAlign="middle" className="app">
      <Grid.Column style={{ maxWidth: 450 }}>
        <Header as="h1" icon color="teal" textAlign="center">
          <Icon name="user circle" />
          Login
        </Header>
        <Form size="large">
          <Segment stacked>
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
            <Form.Button color="teal" fluid size="large">
              Sign in
            </Form.Button>
          </Segment>
        </Form>
        <Message>
          Don't have an account? <Link to="/auth/register">Register</Link>
        </Message>
      </Grid.Column>
    </Grid>
  )
}

export default Login
