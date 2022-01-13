import { Menu } from 'semantic-ui-react'
import { ChannelProps } from '.'

export const Channel = ({ channel }: ChannelProps) => {
  return (
    <Menu.Item
      key={channel.id}
      onClick={() => console.log(channel.name)}
      name={channel.name}
      style={{ opacity: 0.7 }}
    >
      # {channel.name}
    </Menu.Item>
  )
}
