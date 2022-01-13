import { AnyAction } from 'redux'
import { IChannel } from '../../models/channelModel';
import { ActionType } from './channel';

/**
 * https://github.com/acdlite/flux-standard-action
 */


interface AddChannelsAction extends AnyAction {
  type: ActionType.ADD_CHANNELS
  channels: IChannel[]
}

interface AddChannelAction extends AnyAction {
  type: ActionType.ADD_CHANNEL
  channel: IChannel
}

interface RemoveChannelsAction extends AnyAction {
  type: ActionType.REMOVE_CHANNELS
  channels: IChannel[]
}

export type ChannelAction = AddChannelsAction | AddChannelAction | RemoveChannelsAction;
