package Homework2.FactoryMethod;

public class ConcreteReaderCreator extends BaseLogReaderCreator{
    @Override
    protected LogReader createLogReaderInstance(LogType logType) {

        return switch (logType){
            case Text -> new TextFileReader();
            case Database -> new DatabaseReader();
            case System -> new OperationSystemLogEventsReader();
        };
    }
}
