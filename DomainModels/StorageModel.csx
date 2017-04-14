using System; 

public abstract class StorageModel
{
    public void NewId(string partitionKey)
    {
        this.PartitionKey = partitionKey;
        this.RowKey = Guid.NewGuid().ToString();
    }

    public string PartitionKey {get;set;}
    public string RowKey {get;set;}
}
