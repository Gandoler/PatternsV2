namespace Lab3;

abstract class AirplaneUnit
{
    public abstract double GetBaggageWeight();
    public virtual void Add(AirplaneUnit unit) => throw new NotImplementedException();
    public virtual void Remove(AirplaneUnit unit) => throw new NotImplementedException();
    public virtual void RemoveExcessBaggage(double excess) => throw new NotImplementedException();
    public virtual void PrintLoadingMap() => throw new NotImplementedException();
    public virtual void CheckOverweight() => throw new NotImplementedException();
}