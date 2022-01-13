import { IChannel } from "../../models/channelModel";

export interface ChannelPayload {
  channel: IChannel
  channels: IChannel[]
}
export interface ChannelState {
  channels: IChannel[]
}

export enum ActionType {
  ADD_CHANNEL = "ADD_CHANNEL",
  ADD_CHANNELS = "ADD_CHANNELS",
  REMOVE_CHANNELS = "REMOVE_CHANNELS",
}