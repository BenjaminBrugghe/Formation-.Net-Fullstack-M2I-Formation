export interface IConnector
{
    connector():boolean;
}

export class WifiConnector implements IConnector
{
    connector(): boolean {
        console.log("Wifi connector");
        return true;
    }  
}
export class BluetoothConnector implements IConnector
{
    connector(): boolean {
        console.log(" Bluetooth Connector");
        return true;
    } 
}
export class Hd4k implements IConnector
{
    connector(): boolean {
        throw new Error("Method not implemented.");
    }

}

export class System
{
    constructor(private connector: IConnector)
    {

    }
}
let wifi =new WifiConnector();
let Bluetooth=new BluetoothConnector();
let system=new System(wifi);
let system2=new System(Bluetooth);


