import { useEffect } from 'react'
import { Dropdown, Grid, Header, Icon } from 'semantic-ui-react'

import { ADD_CHANNELS } from '../../store/types/channelTypes'

export const UserPanel = () => {
  const dropdownOptions = [
    {
      key: 'user',
      text: (
        <span>
          Logged as: <strong>User</strong>
        </span>
      ),
      disabled: false,
    },
    {
      key: 'avatar',
      text: <span>Change avatar</span>,
      disabled: false,
    },
  ]

  return (
    <Grid style={{ background: '#4c3c4c', margin: 0 }}>
      <Grid.Column>
        <Grid.Row style={{ padding: '1.2em', margin: 0 }}>
          <Header floated="left" as="h2" inverted>
            <Icon name="code" />
            <Header.Content>NetChat</Header.Content>
          </Header>
        </Grid.Row>
        <Header style={{ padding: '0.25em' }} as="h4" inverted>
          <Dropdown
            trigger={<span>User</span>}
            options={dropdownOptions}
          ></Dropdown>
        </Header>
      </Grid.Column>
    </Grid>
  )
}
