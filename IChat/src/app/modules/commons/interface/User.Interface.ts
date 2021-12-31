export interface UserInterface {
    id: number,
    DT_Nome: string,
    DT_Email: string,
    DT_Password: string,
    roles?: string[],
    level?: number
}
