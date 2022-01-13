import { useState, ChangeEvent } from 'react'

export const useForm = <T>(initialForm: T) => {
  const [form, setForm] = useState<T>(initialForm)

  const handleChange = ({ target }: ChangeEvent<HTMLInputElement>) => {
    const { name, value } = target
    setForm({ ...form, [name]: value })
  }

  const reset = () => setForm(initialForm)

  return {
    form,
    reset,
    ...form,
    handleChange,
  }
}