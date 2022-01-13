import { createAsyncThunk } from "@reduxjs/toolkit"
import agent from "../../api/agent"
import { IChannel } from "../../models/channelModel"
import { v4 as uuid } from "uuid" 

export const addNewChannel = createAsyncThunk('channel/addChannel', async (channel: IChannel) => {
  await agent.channels.create(channel)
  const newChannel = {
    ...channel,
    id: uuid(),
  }
  return newChannel
})

export const loadChannel = createAsyncThunk('channel/loadChannels', async () => {
  const channels = await agent.channels.list()
  return channels
})