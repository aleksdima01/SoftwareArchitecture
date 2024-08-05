package Homework1.InMemory;

public interface IModelChanger {
/**
 * Отслеживаем изменения в хранилише моделей
 */
void notifyChange();
void RegisterModelChanger(IModelChangedObserver o);
void RemoveModelChanger(IModelChangedObserver o);

}
