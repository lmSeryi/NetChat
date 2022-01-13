import axios, { AxiosResponse } from 'axios'
import { IChannel } from '../models/channelModel'
import { API } from '../utils/constants'

axios.defaults.baseURL = API

const responseBody = (response: AxiosResponse) => response.data

const request = {
  get: (url: string) => axios.get(url).then(responseBody),
  post: (url: string, body: {}) => axios.post(url, body).then(responseBody),
  put: (url: string, body: {}) => axios.put(url, body).then(responseBody),
  del: (url: string) => axios.delete(url).then(responseBody)
}

const channels = {
  list: () : Promise<IChannel[]> => request.get('/channels'),
  create: (channel : IChannel) => request.post('/channels', channel),
  update: (channel : IChannel) => request.put(`/channels/${channel.id}`, channel),
  delete: (id: string) => request.del(`/channels/${id}`)
}

export default { channels }