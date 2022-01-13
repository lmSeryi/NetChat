import { Button, Input, Segment } from 'semantic-ui-react'

export const MessageForm = () => {
  return (
    <Segment>
      <Input
        name="message"
        label={<Button icon="add" />}
        style={{ marginBottom: '0.7em' }}
        labelPosition="left"
        placeholder="Type your message..."
        fluid
      />
      <Button.Group icon widths="2">
        <Button
          color="orange"
          content="Add Reply"
          labelPosition="left"
          icon="edit"
        />
        <Button
          color="teal"
          content="Upload Media"
          labelPosition="right"
          icon="cloud upload"
        />
      </Button.Group>
    </Segment>
  )
}
