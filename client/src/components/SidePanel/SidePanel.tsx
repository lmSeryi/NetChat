import { Menu } from 'semantic-ui-react'
import { Channels } from './Channels'
import { UserPanel } from './UserPanel'

const SidePanel = () => {
  return (
    <Menu
      size="large"
      fixed="left"
      style={{ background: '#4c3c4c', fontSize: '1.2rem' }}
      inverted
      vertical
    >
      <UserPanel />
      <Channels />
    </Menu>
  )
}

export default SidePanel
