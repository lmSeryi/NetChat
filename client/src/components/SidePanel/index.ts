import { IChannel } from '../../models/channelModel'

export { default } from './SidePanel'

type SetChannels = React.Dispatch<React.SetStateAction<IChannel[]>>

export interface ChannelsProps {
  channels: IChannel[]
}

export interface ChannelProps {
  channel: IChannel
}

export interface AddChannelResponse {
  status: boolean
  data: IChannel
}