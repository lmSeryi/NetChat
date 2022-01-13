import { Button, Divider, Menu, Sidebar } from 'semantic-ui-react'

const ColorPanel = () => {
  return (
    <Sidebar
      as={Menu}
      icon="labeled"
      width="very thin"
      inverted
      vertical
      visible
    >
      <Divider />
      <Button icon="add" side="small" color="blue" />
    </Sidebar>
  )
}

export default ColorPanel
