import React from 'react'
import { Form, Input } from 'semantic-ui-react'

interface ChannelFormProps {
  name: string
  description: string
  handleChange: (e: React.ChangeEvent<HTMLInputElement>) => void
}

export const ChannelForm = ({
  name,
  description,
  handleChange,
}: ChannelFormProps) => {
  return (
    <Form>
      <Form.Field>
        <Input
          label="Channel Name"
          name="name"
          value={name}
          onChange={handleChange}
          fluid
        />
      </Form.Field>
      <Form.Field>
        <Input
          label="Description"
          name="description"
          value={description}
          onChange={handleChange}
          fluid
        />
      </Form.Field>
    </Form>
  )
}
