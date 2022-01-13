import { createSlice } from '@reduxjs/toolkit'
import { IChannel } from '../../models/channelModel'
import { addNewChannel, loadChannel } from '../actions/channelActions'

import toast from 'react-hot-toast'


interface ChannelState {
  data: IChannel[]
  loading: boolean
  error: string | null | undefined
}

const initialState: ChannelState = {
  data: [],
  loading: false,
  error: null,
}

const channelSlice = createSlice({
  name: 'channel',
  initialState,
  reducers: {
    isLoading(state) {
      state.loading = !state.loading
    }
  },
  extraReducers: builder => {
    builder.addCase(addNewChannel.fulfilled, (state, action) => {
      state.data.push(action.payload)
      state.error = null
      state.loading = false
    })
    builder.addCase(addNewChannel.rejected, (state, action) => {
      state.error = action.error.message
      if (state.error) {
        toast.error(state.error)
      }
    })
    builder.addCase(loadChannel.fulfilled, (state, action) => {
      state.data.push(...action.payload)
      state.error = null
      state.loading = false
    })
    builder.addCase(loadChannel.rejected, (state, action) => {
      state.error = action.error.message
      if (state.error) {
        toast.error(state.error)
      }
    })
  }
})

export const { isLoading } = channelSlice.actions

export default channelSlice.reducer
