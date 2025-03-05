from fastapi import FastAPI, HTTPException
from pydantic import BaseModel
from typing import List, Optional

app = FastAPI(title="Survivor API")

# Base Entity
class BaseEntity(BaseModel):
    id: int

# Category Model
class Category(BaseEntity):
    name: str

# Competitor Model
class Competitor(BaseEntity):
    name: str
    age: int
    category_id: int

# In-memory database
categories = []
competitors = []

# Category Controller
@app.get("/api/categories", response_model=List[Category])
def get_categories():
    return categories

@app.get("/api/categories/{id}", response_model=Category)
def get_category(id: int):
    for category in categories:
        if category.id == id:
            return category
    raise HTTPException(status_code=404, detail="Category not found")

@app.post("/api/categories", response_model=Category)
def create_category(category: Category):
    categories.append(category)
    return category

@app.put("/api/categories/{id}", response_model=Category)
def update_category(id: int, updated_category: Category):
    for index, category in enumerate(categories):
        if category.id == id:
            categories[index] = updated_category
            return updated_category
    raise HTTPException(status_code=404, detail="Category not found")

@app.delete("/api/categories/{id}")
def delete_category(id: int):
    global categories
    categories = [category for category in categories if category.id != id]
    return {"message": "Category deleted"}

# Competitor Controller
@app.get("/api/competitors", response_model=List[Competitor])
def get_competitors():
    return competitors

@app.get("/api/competitors/{id}", response_model=Competitor)
def get_competitor(id: int):
    for competitor in competitors:
        if competitor.id == id:
            return competitor
    raise HTTPException(status_code=404, detail="Competitor not found")

@app.get("/api/competitors/categories/{category_id}", response_model=List[Competitor])
def get_competitors_by_category(category_id: int):
    return [competitor for competitor in competitors if competitor.category_id == category_id]

@app.post("/api/competitors", response_model=Competitor)
def create_competitor(competitor: Competitor):
    competitors.append(competitor)
    return competitor

@app.put("/api/competitors/{id}", response_model=Competitor)
def update_competitor(id: int, updated_competitor: Competitor):
    for index, competitor in enumerate(competitors):
        if competitor.id == id:
            competitors[index] = updated_competitor
            return updated_competitor
    raise HTTPException(status_code=404, detail="Competitor not found")

@app.delete("/api/competitors/{id}")
def delete_competitor(id: int):
    global competitors
    competitors = [competitor for competitor in competitors if competitor.id != id]
    return {"message": "Competitor deleted"}
