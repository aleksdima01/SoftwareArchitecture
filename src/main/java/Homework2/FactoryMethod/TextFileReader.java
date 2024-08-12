package Homework2.FactoryMethod;

public class TextFileReader extends LogReader {
    private String text;

    @Override
    public Object getDataSource() {
        return text;
    }

    @Override
    public void setDataSource(Object data) {
        this.text = data.toString();
    }

    @Override
    protected Iterable<String> readEntries(Integer position) {
        return null;
    }

    @Override
    protected LogEntry parseLogEntry(String stringEntry) {
        return new LogEntry(stringEntry);
    }

    public TextFileReader(String text) {
        this.text = text;
    }

    public TextFileReader() {
    }
}
