import { IChannel } from "./channelModel";

export interface RequestGetChannels {
  data: IChannel[]
  status: number
}

export interface RequestAddChannel {
  data: IChannel
  status: number
}